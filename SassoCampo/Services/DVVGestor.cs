using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BE;
using DAL;
using Interfaces;

namespace BLL
{
    public class DVVGestor : IHasheable
    {
        DALDVV bd;

        public DVVGestor()
        {
            bd = new DALDVV();
        }

        public void Alta(DVV dvv)
        {
            bd.Alta(dvv);
        }

        public void Modificar(DVV dvv)
        {
            dvv = bd.GetDVV(dvv);
            dvv.Hash = CalcularDVV(dvv);
            bd.Modificar(dvv);
        }

        public bool VerificarDVV(DVV dvv)
        {
            dvv = bd.GetDVV(dvv);
            if( dvv.Hash != CalcularDVV(dvv))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string CalcularDVV(DVV dvv)
        {
            string ParcialHash = "";
            foreach (var dvh in bd.GetTableDVV(dvv))
            {
                ParcialHash += dvh;
            }
            return GetHash(ParcialHash);
        }

        public string GetHash(string input)
        {
            using (MD5 hasher = MD5.Create())
            {
                byte[] dato = hasher.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
                string hasheado = "";
                for (int i = 0; i < dato.Length; i++)
                {
                    hasheado += dato[i].ToString();
                }
                return hasheado;
            }
        }
    }
}
