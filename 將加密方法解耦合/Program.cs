using System;
using System.Text;

namespace consoleTest
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "helloworld";

      byte[] strByte = Encoding.Default.GetBytes(str);
      var cryptography = new CryptoService(new MD5Hash());
      byte[] hashByte = cryptography.getHash(strByte);
      
      Console.WriteLine("MD5 加密");
      Concat(hashByte);

      Console.WriteLine("\nSHA1 加密");
      cryptography = new CryptoService(new SHA1Hash());
      hashByte = cryptography.getHash(strByte);
      Concat(hashByte);

      Console.WriteLine("\nSHA256 加密");
      cryptography = new CryptoService(new SHA256Hash());
      hashByte = cryptography.getHash(strByte);
      Concat(hashByte);
      Console.WriteLine();
      
    }
    static void Concat(byte[] hashByte){
      string hashString="";
      foreach (var item in hashByte)
      {
        hashString += item.ToString("x2");
      }
      Console.Write(hashString);
    }
  }
  
}
