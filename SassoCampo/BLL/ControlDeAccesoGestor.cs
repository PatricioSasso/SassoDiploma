using DAL;
using System.Security.Cryptography;
using System.Text;

public class ControlDeAccesoGestor
{
    DALUsuario bd;

    public ControlDeAccesoGestor()
    {
        bd = new DALUsuario();
    }

    public bool LogIn(string nombreUsuario, string contraseña)
    {
        return bd.LogIn(nombreUsuario, contraseña);
    }

    public Usuario GetUsuario(Usuario usuario)
    {
        return bd.GetUsuario(usuario);
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
