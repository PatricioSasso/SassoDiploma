using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
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
