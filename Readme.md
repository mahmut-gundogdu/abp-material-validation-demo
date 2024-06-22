# How to use Angular Material with Validation On ABP

ABP framework  (angular) has its own validation mechanism. By default It may problem with Angular material. In this example, I want to show how to use ABP clientside validation with Material (ngx-validate)

### Creating project

I use that settings. 
`abp new BookStoreMaterial -t app-nolayers -u angular -dbms SQLite --theme basic -csf`

BE and Theme option is a little bit off topic due that I choosed most simples one.


### Add angular material in project.

To add Angular Material to your project, you can use the `ng add` command. Open your terminal and navigate to the root directory of your project. Then, run the following command:

```
ng add @angular/material
```

This command will install Angular Material and its dependencies, as well as configure your project to use Angular Material.


### Form Validation
we have simple form with validation rule

```js
this.form = this.formBuilder.group({
  name: ['', Validators.required],
  email: ['', [Validators.required, Validators.email]],
  password: ['', [Validators.required, Validators.minLength(6)]],
});
```

When the user click the submit button errors shown. Yes it works but expected visual behavior is not fit.
 
 ![Image](img/1.png)


mat-form-field get access to error component and placed in the dom. You can check that How it works Angular material form error. 
 https://material.angular.io/components/form-field/overview#error-messages

```html
 <mat-form-field class="col">
      <mat-label>First Name</mat-label>
      <input matInput formControlName="firstName" />
       @if (firstName.invalid) {
      <mat-error>{{"AbpValidation::ThisFieldIsRequired" | abpLocalization}}</mat-error>
        }
    </mat-form-field>
```
 ![Step2](img/2.png)
Yes it better but we have two error message.  1 added by NgxValidate , 2 added by developer.

We be able to disable NgxValidation by a attribute that name is `skipValidation`

![Step3](img/3.png)
but We have to add localization message one by one. it is so repetative. 

We can created error messages by NgxValidate with ValidationContainer attribute and `validationTarget` attribute. `validateContainer` directive is a pointer. it define/mark a parent for error message. `validationTarget` is a mark the place that added error message.

```html
    <mat-form-field class="col" validationContainer>
      <mat-label>First Name</mat-label>
      <input matInput formControlName="firstName" />
      <mat-error validationTarget />
    </mat-form-field>
```

but still I have a visual problem. Because ngx-validate added validation message as sibling. 

![Step4](img/4.png)

```css
mat-error {
  display: none !important;
}
.mat-mdc-form-field-error-wrapper .invalid-feedback{
  display:inline;
}
```

it works!

![Step5](img/5.png)
