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
The idea of this project came along time ago and the reason was a collage of mine who dreamed to become a pizza master chef. He neglected all his job as a programmer and start to make a pizza. Nothing wrong with that Alex! That is why I decided to help him creating this project. The project represents a simple form to order food and drinks thru this app. Here I use a reactive forms to manage the user input. That is why the first thing after creation my app was to import { ReactiveFormsModule } in to "app.module.ts".
<br />

`import { ReactiveFormsModule } from '@angular/forms';`

<br />
The project starts with a header and component which presents the header background image.

```
<div class="header">
    <app-images></app-images>
</div> 
```
Then I set food images on both sides of the body. For this puspose I created another two separate components in my component folder
```
<background_images_left>
<background_images_right>
```
On this project I used SCSS instead CSS. Next to it I created a form which hold the "food" and the "drinks" selectors.  and another form which contains the inputs for "name-address-phone". The "food" and "drinks" forms along with "address-name-phone" form have at the bottom json pipe.
```
{{ value_expression | json }}
```
Json pipe converts a value into its JSON-format. When the customer make his order, json changing it's value on the bootom of that page. In to the all of my components in theirs "ts" file I have used the "createFomr()" method, which contains the definition of my form fields. The exception is the "counter-input" component. My goal was to make my app more dynamic. That is why I imported "RouterModule" in to my app.module.ts file. 
```
import { RouterModule } from '@angular/router';
```
Then I needed to add my navigation path and components to the imports array of @NgModule() section of app.module.ts file.
```
imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: 'home', component: HomeComponent},
      {path: 'about', component: AboutComponent},
      {path: 'contact', component: ContactComponent},
      {path: '', redirectTo: '/home', pathMatch: 'full'},
      {path: '**', component: PageNotFoundComponent}
    ]),............
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
