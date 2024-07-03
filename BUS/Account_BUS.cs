using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Account_BUS
    {

        public static Account_DTO layTaiKhoan( string sTen, string sMatKhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = Account_BUS.getMD5Hash(md5Hash, sMatKhau);
            return Account_DAO.layTaiKhoan( sTen, matkhauMH);
        }

        public static bool DoiMatKhau(Account_DTO nd, string mkMoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = Account_BUS.getMD5Hash(md5Hash, mkMoi);
            return Account_DAO.DoiMatKhau(nd, matkhauMH);
        }

        private static string getMD5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool Them(Account_DTO tk)
        {
            MD5 md5Hash = MD5.Create();
            tk.Password = Account_BUS.getMD5Hash(md5Hash, tk.Password);
            return Account_DAO.Them(tk);
        }

        public static bool XoaTaiKhoan(string ten)
        {
            return Account_DAO.XoaTaiKhoan(ten);
        }
    }
}
