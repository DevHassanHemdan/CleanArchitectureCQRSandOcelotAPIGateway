import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { tap } from 'rxjs';
import { LoginService } from './../Shared/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  token = '';
  constructor(public loginService: LoginService, private _router: Router) { }

  ngOnInit(): void {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form?.reset();
    this.loginService.formData = {
      email: '',
      password: ''
    }
  }

  login(form: NgForm) {
    this.loginService.login().pipe(
      tap((response: any) => {
        localStorage.setItem('token', response.token)

      })
    ).subscribe(s => {
      this._router.navigate(['products']);
    })
  }

}
