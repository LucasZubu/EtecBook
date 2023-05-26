import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  registerForm! : FormGroup;

  constructor(private fb: FormBuilder){}

  ngOnInit(){
    this.registerForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', Validators.compose([Validators.required, Validators.email])],
      password: ['', Validators.compose([Validators.required, Validators.minLength(6)])]
    })
  }

  get f(){
    return this.registerForm.controls;
  }

  checkName(){
    return this.f['name'].dirty && this.f['name'].errors?.['required'];
  }

  checkEmail(){
    return this.f['email'].dirty && this.f['email'].errors?.['required'];
  }

  checkEmailValid(){
    return this.f['email'].dirty && this.f['email'].errors?.['email'];
  }

  checkPassword(){
    return this.f['password'].dirty && this.f['password'].errors?.['required'];
  }

  checkPasswordLemgth(){
    return this.f['password'].dirty && this.f['password'].errors?.['minlength'];
  }

  onSubmit(){
    if (this.registerForm.valid){
      //Enviar os dados para Api
      console.log(this.registerForm.value);      
    } else {
      //Dispara um erro
      this.validateAllFormFields(this.registerForm);
    }
  }

  private validateAllFormFields(formGroup : FormGroup){
    Object.keys(formGroup.controls).forEach(field =>{
      const control = formGroup.get(field)
      if (control instanceof FormControl){
        control.markAsDirty({onlySelf : true});
      } else if (control instanceof FormGroup){
        this.validateAllFormFields(control);
      }
    })
  }


}
