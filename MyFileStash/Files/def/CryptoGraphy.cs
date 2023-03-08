using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static MyFileStash.Files.def.Vars;

namespace MyFileStash.Files.def
{
    class CryptoGraphy
    {
        public static void EncryptFile(string inputFile)
        {
            try
            {

                byte[] salt = Encoding.ASCII.GetBytes(strSalt);
                byte[] iv = Encoding.ASCII.GetBytes(strIV);
                byte[] key = new Rfc2898DeriveBytes(strKey, salt, 10000, HashAlgorithmName.SHA256).GetBytes(32);  //gen a secure key using PBKDF2

                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.Key = key;
                    aes.IV = iv;

                    string outputfile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileName(inputFile) + ".encrypted");

                    using (FileStream ifs = new FileStream(inputFile, FileMode.Open))
                    using (FileStream opfs = new FileStream(outputfile, FileMode.Create))
                    {
                        //write salt, iv to beginning of the output file
                        opfs.Write(salt, 0, salt.Length);
                        opfs.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new CryptoStream(opfs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            int blockSizeBytes = aes.BlockSize / 8;
                            byte[] buffer = new byte[blockSizeBytes];
                            int bytesRead;
                            while ((bytesRead = ifs.Read(buffer, 0, blockSizeBytes)) > 0)
                            {
                                cryptoStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }

                    File.Delete(inputFile);
                }

                MessageBox.Show("Your files was encrypt.", "MyFileStash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MyFileStash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DecryptFile(string inputFile)
        {
            try
            {
                byte[] salt = Encoding.ASCII.GetBytes(strSalt);
                byte[] iv = Encoding.ASCII.GetBytes(strIV);
                byte[] key = new Rfc2898DeriveBytes(strKey, salt, 10000, HashAlgorithmName.SHA256).GetBytes(32);

                using (FileStream ifs = new FileStream(inputFile, FileMode.Open))
                {
                    ifs.Read(salt, 0, salt.Length);
                    ifs.Read(iv, 0, iv.Length);

                    using (Aes aes = Aes.Create())
                    {
                        aes.KeySize = 256;
                        aes.BlockSize = 128;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;
                        aes.Key = key;
                        aes.IV = iv;

                        string outputfile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile));

                        using (FileStream opfs = new FileStream(outputfile, FileMode.Create))
                        using (CryptoStream cryptoStream = new CryptoStream(ifs, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            int blockSizeBytes = aes.BlockSize / 8;
                            byte[] buffer = new byte[blockSizeBytes];
                            int bytesRead;
                            while ((bytesRead = cryptoStream.Read(buffer, 0, blockSizeBytes)) > 0)
                            {
                                opfs.Write(buffer, 0, bytesRead);
                            }
                        }
                    }

                    File.Delete(inputFile);
                }

                MessageBox.Show("Your files was decrypt.", "MyFileStash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MyFileStash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
