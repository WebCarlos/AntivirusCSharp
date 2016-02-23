using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusTotalNET;
using VirusTotalNET.Objects;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Management;






namespace AntivirusForm
{
    
    public class VirusTotalAux
    {
        public String Nombre { get; set; }
        public String Positivos { get; set; }
        public String Mensaje { get; set; }
        public String ScanDate { get; set; }
        public List<VirusTotalResultAux> resultados { get; set; }
    }


    public class VirusTotalResultAux
    {
        public String Antivirus { get; set; }
        public bool Infectado { get; set; }
        public String Virus { get; set; }
    }
    public class Ruta
    {
        public String Proceso { get; set; }
    }
   
    public class VirusTotalSend
    {
        public VirusTotal _virusTotal;
        public List<Ruta> _lista = new List<Ruta>();
        List<VirusTotalAux> _listaScan = new List<VirusTotalAux>();
        List<VirusTotalResultAux> _listaResultados = new List<VirusTotalResultAux>();
        //FileInfo fileInfo = new FileInfo("C:\\Users\\Antonio\\Documents\\file.txt");
        public List<VirusTotalAux> send()
        {
            _virusTotal = new VirusTotal(ConfigurationManager.AppSettings["ApiKey"]);
            _listaScan.Clear();
            _listaResultados.Clear();
  
            int count=0;
            while (count < 2)
            {
                string ruta = _lista[count].Proceso;
                ruta = ruta.Replace(@"\", @"\\");
                FileInfo fileInfo = new FileInfo(ruta);
                
                _virusTotal.UseTLS = true;
                FileReport fileReport = _virusTotal.GetFileReport(fileInfo);
                bool hasFileBeenScannedBefore = fileReport.ResponseCode == ReportResponseCode.Present;

                if (hasFileBeenScannedBefore)
                {
                    VirusTotalAux aux = new VirusTotalAux {Nombre=fileInfo.Name, Mensaje=fileReport.VerboseMsg,Positivos=fileReport.Positives.ToString()+"/"+fileReport.Total.ToString(), ScanDate=fileReport.ScanDate.ToString()  };
                    
                    
                    foreach(ScanEngine scan in fileReport.Scans){
                        VirusTotalResultAux aux2 = new VirusTotalResultAux { Antivirus = scan.Name, Infectado = scan.Detected, Virus = scan.Result };
                        _listaResultados.Add(aux2);
                    }
                    aux.resultados = _listaResultados;
                    _listaScan.Add(aux);
                    
                    //PrintScan(fileReport);
                }
                else
                {
                    ScanResult fileResult = _virusTotal.ScanFile(fileInfo);
                    VirusTotalAux aux = new VirusTotalAux { Mensaje = fileResult.VerboseMsg };
                    aux.resultados = _listaResultados;
                   
                    //Console.WriteLine(fileResult.VerboseMsg);
                    //PrintScan(fileResult);
                }


                count++;
            }
            return _listaScan;

        }

        public List<String> ObtenerProcesos()
        {
            List<String> _lista2 = new List<string>();
            Process[] procesos;
            procesos = Process.GetProcesses();
            foreach (Process pro in procesos)
            {
                _lista2.Add(pro.ProcessName);
            }

            return _lista2;
        }

        public void RecuperarProcesos()
        {
           
            var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            using (var results = searcher.Get())
            {

                var query = from p in Process.GetProcesses()
                            join mo in results.Cast<ManagementObject>()
                            on p.Id equals (int)(uint)mo["ProcessId"]
                            select new
                            {
                                Process = p,
                                Path = (String)mo["ExecutablePath"],
                                CommandLine = (String)mo["CommandLine"],
                            };
                foreach (var item in query)
                {
                    if (item != null)
                    {
                        if(item.Path != null && !item.Path.Equals("")){
                            _lista.Add(new Ruta{Proceso= item.Path});
                        }
                        
                    }
                        

                }
            }
            
        }
    }
}
