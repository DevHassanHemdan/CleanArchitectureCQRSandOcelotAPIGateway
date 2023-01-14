import { Injectable } from '@angular/core';
import { IUser } from './../models/user.model';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { IsuerDTO } from '../models/UsetDTO.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  formData: IUser;
  userDTO: IsuerDTO;
  constructor(private _http: HttpClient) { }

  login() {
    return this._http.post(environment.url + 'api/User/login', this.formData);
  }
}
