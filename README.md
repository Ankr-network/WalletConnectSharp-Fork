# WalletConnectSharp-Fork
This repository contains a fork of WalletConnectSharp implementation required to combine its WalletConnect 2.0 protocol features with AnkrSDK repository. 

Initial state of this repo is coming from [this commit](https://github.com/WalletConnect/WalletConnectSharp/commit/b9265e866179e33b7b853f03c7fc79047f1cbb1f) of [WalletConnectSharp](https://github.com/WalletConnect/WalletConnectSharp) repo.

The core change we had to do in order to make DLLs built with this repo solution compatible with AnkrSDK implementation is to remove WalletConnectSharp.Crypto project dependency on BouncyCastle.Cryptography nuget package in order to avoid duplicate classes compilation error since AnkrSDK already contains BouncyCastle.Crypto DLL with a subset of classes contained in BouncyCastle.Cryptography. Instead of using BouncyCastle.Cryptography nuget dependency we created Imported folder in WalletConnectSharp2.Crypto project of this repo and moved all of the required classes from [BouncyCastle.Cryptography github repo](https://github.com/bcgit/bc-csharp) v2.0 release branch [commit](https://github.com/bcgit/bc-csharp/4f800b4d3229a011a8126d4aea698a3e14d0dd53) directly to Imported folder. We also nad to rename several namespaces from WalletConnectSharp.* to WalletConnectSharp2.* to avoid duplicate class names.