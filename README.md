# Extension of .NET Framework Classes to Support DSA for Digital Signatures

## Introductory Information

<img src="https://github.com/user-attachments/assets/9002855f-3f97-4b41-a180-85d1e24ad34a" alt="University Logo" width="150" align="right"/>

**University of Prishtina**  
**Faculty of Computer and Software Engineering**  
Master’s Program in **Computer and Software Engineering**  
Course: **Information Security**  


## Course Professors

- **Blerim Rexha**
- **Mergim Hoti**

## Project Team Members (Group 2)

- **Argjend Zekaj**
- **Bleron Morina**
- **Endrit Gjoka**

## Overview

The **Custom Security Extensions** project provides a graphical user interface (GUI) for generating and verifying Digital Signature Algorithm (DSA) signatures. It enables users to sign messages or files securely, leveraging the **CustomDSASignature** class for cryptographic operations, including the creation, signing, and verification of digital signatures.

## Prerequisites

To run this project, ensure the following are installed:
- .NET Framework 4.x or .NET Core (as applicable)
- Visual Studio or any C# IDE
- Windows Forms dependencies

## Features

- **Signing Messages**:  
  - Enter a text message in the input field or select a file to read the content from.  
  - Click the **Sign** button to generate a digital signature.  
  - The generated signature will appear in the signature text box.

- **Verifying Messages**:  
  - Provide a text message or select a file whose content needs to be verified.  
  - Paste or enter the previously generated signature in the appropriate field.  
  - Click the **Verify** button to validate the signature.

## Usage

1. **Generate a Digital Signature**  
   - Input or upload the message/file you want to sign.
   - Press the **Sign** button.
   - The signature will be displayed in the text box for further use or verification.

2. **Verify a Digital Signature**  
   - Input or upload the message/file whose signature you want to verify.
   - Paste the corresponding signature.
   - Press the **Verify** button to check if the signature matches the content.
