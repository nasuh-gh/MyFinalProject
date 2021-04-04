using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //Burası verdiğimiz password ün hash ini oluşturmaya yarıyor
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }
        //burdaki sonradan sisteme girmek isteyen kişinin verdiği password ün veritabanındaki hash le ilgili Salta göre eşleşip eşleşmediğini verdiğimiz yerdir
        public static bool VerifyPasswordHash(string password, byte[] passwordHash,byte[] passwordSalt)//passwor hash ini doğrula demek
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
