# MyFileStash

> Using the Advanced Encryption Standard (AES) algorithm with a key size of 256 bits and a block size of 128 bits in Cipher Block Chaining (CBC) mode, this project offers a quick and secure solution to encrypt and decrypt data. 
The original file is deleted after encryption, and a new file with the extension ".encrypted" is created in the same directory as the original one. 
By turning back the encryption process, the decryption procedure restores the original file from the encrypted file. 
To create a safe key for encryption, this project use the password-based key derivation algorithm 2 (PBKDF2) along with the SHA-256 hash function and a salt value. 
The initialization (IV) variables and salt are additionally utilized to randomize the encryption procedure and prevent pattern-based attacks.


