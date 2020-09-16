using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Service
{
    public class Program
    {
        // Uncomment the following line to resolve.
        static void Main() {}
    }

    public class BackupAndRestoreGestor
    {
        DALBackUpAndRestore bd;

        public BackupAndRestoreGestor()
        {
            bd = new DALBackUpAndRestore();
        }

        public void Backup(string ruta)
        {
            bd.Backup(ruta);
        }

        public void Restore(string ruta)
        {
            bd.Restore(ruta);
        }
    }
}
