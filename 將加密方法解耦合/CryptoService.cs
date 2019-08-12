namespace consoleTest
{
  using System.Security.Cryptography;
  class CryptoService
  {
    private ICrypto _crypto;

    public CryptoService(ICrypto crypto)
    {
        _crypto = crypto;
    }
    public byte[] getHash(byte[] str){
      return _crypto.hash(str);
    }
  }

  
  public class SHA1Hash : ICrypto
  {
    public byte[] hash(byte[] strByte)
    {
      SHA1 sha = new SHA1CryptoServiceProvider();
      byte[] hashStr = sha.ComputeHash(strByte);
      return hashStr;
    }
  }
  public class MD5Hash : ICrypto
  {
    public byte[] hash(byte[] strByte)
    {
      MD5 sha = new MD5CryptoServiceProvider();
      byte[] hashStr = sha.ComputeHash(strByte);
      return hashStr;
    }
  }
  public class SHA256Hash : ICrypto
  {
    public byte[] hash(byte[] strByte)
    {
      SHA256 sha = new SHA256CryptoServiceProvider();
      byte[] hashStr = sha.ComputeHash(strByte);
      return hashStr;
    }
  }
}
