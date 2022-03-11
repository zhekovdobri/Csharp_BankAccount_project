<img align="justify" alt="chart" width="950px" src="https://github.com/zhekovdobri/Csharp_BankAccount_project/blob/main/C%23_BankAccount_project1200px.png">

# C#_BankAccount_project

#### By: Dobri Zhekov

#### [<ins>Check the entire project here</ins>](https://github.com/zhekovdobri/Csharp_BankAccount_project)

## Technologies Used

<div class=pull-left>

</div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<div class=pull-right>
<img align="right" alt="chart" height="200px" src="https://github.com/zhekovdobri/Csharp_BankAccount_project/blob/main/C%23_language_chart.png">
</div>

* _C#_

<br />

## Description
A simple C# application which represents a bank account. It contains three classes:

```
1. Program.cs
2. BankAccount.cs
3. Transaction.cs
```
The second class contains the constructor which has the same name as it's class:

```
public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "initialBalance");
        this.Number = accountNumberseed.ToString();
        accountNumberseed++;
    }
```
</div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<div class=pull-right>
<img align="right" alt="chart" height="100px" src="https://github.com/zhekovdobri/Csharp_BankAccount_project/blob/main/Directory_structure_logo.png">
</div>

## Directory structure:

<img alt="chart" src="https://github.com/zhekovdobri/Csharp_BankAccount_project/blob/main/C%23%20Directory%20structure.png">

## Setup/Installation Requirements

### Clone a repository using the command line 

1. From the repository, click "Code" and copy the address (either the SSH format or the HTTPS). 
2. From a terminal window (cmd or Bash), change to the local directory where you want to clone your repository.
3. Paste the address you copied from GitHub, with one of the next comand:

* **Clone over HTTPS**<br>
  $ git clone (https://..)
  
* **Clone over SSH**<br>
  $ git clone (ssh://..)

## Known Bugs

* No bugs

## License

C#_BankAccount_project is licensed under the GNU GPL 3 license.

<sub><sup>Copiright © 2016-2021 Dobri Zhekov All Rights Reserved</sup></sub>
