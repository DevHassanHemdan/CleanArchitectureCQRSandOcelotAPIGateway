import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { ICategory } from './../models/category.model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  categories: ICategory[];
  token = localStorage.getItem('token')
  hearderOptions = new HttpHeaders().set("Authorization", "bearer " + this.token);
  constructor(private _httpClient: HttpClient) { }

  GetCategories() {
    return this._httpClient.get<ICategory[]>(environment.url + 'api/Category/GetAllCategories', { headers: this.hearderOptions });
  }
}
