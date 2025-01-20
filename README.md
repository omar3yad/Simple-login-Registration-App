# Login and Registration App

This is a simple Login and Registration application built using Windows Forms in C#. The app allows users to either register a new account or log into an existing one. It validates the input fields and ensures that the necessary criteria are met for each action.

## Features

### Registration:

- **Username**: A field to enter the username.
- **Password**: A password field for entering the user's password.
- **Confirm Password**: A confirmation field to re-enter the password and ensure they match.
- **Age**: A numeric input for the user to select their age.
- **Birth Date**: A date picker to select the user's birth date.
- **Gender**: Radio buttons to select gender (Male or Female).
- **Country**: A drop-down menu to select the user's country.
  
![image](https://github.com/user-attachments/assets/c5e27c47-6859-49e4-848e-2d993c5abe6a)

### Login:
- **Username**: A field to enter the username.
- **Password**: A field to enter the password.
- **Login Button**: A button to submit the login request.

![image](https://github.com/user-attachments/assets/9cf74efe-1208-49b0-8d53-1034bef543e3)

### Validation
- The application ensures that the username is not empty.
- The password and confirm password fields must match during registration.
- The user must be at least 18 years old to register.
- A user must have an existing account to log in.

## Requirements

- Microsoft .NET Framework
- Visual Studio or any IDE that supports Windows Forms and C#.
