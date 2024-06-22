import { Component, inject } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatError, MatFormField, MatLabel } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButton } from '@angular/material/button';
import { SharedModule } from '../../shared/shared.module';
import { ErrorStateMatcher, ShowOnDirtyErrorStateMatcher } from '@angular/material/core';
 
@Component({
  selector: 'app-simple-form',
  standalone: true,
  imports: [MatFormField, MatInputModule, MatLabel, MatButton, SharedModule, MatError],
  providers: [
    { provide: ErrorStateMatcher, useClass: ShowOnDirtyErrorStateMatcher },// optional,
  ],
  templateUrl: './simple-form.component.html'
})
export class SimpleFormComponent {
  private readonly fb = inject(FormBuilder);
  form = this.fb.group({
    firstName: ['', [Validators.required,Validators.minLength(2)]],
    lastName: ['', [Validators.required,Validators.minLength(2)]],
    email: ['', [Validators.required, Validators.email]],
   });

   get firstName() { return this.form.get('firstName'); }

  submit() {

  }
}
