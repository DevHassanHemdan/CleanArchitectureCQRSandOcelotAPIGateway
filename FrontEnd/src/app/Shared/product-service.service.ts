import { Injectable } from '@angular/core';
import { IProduct } from '../models/product.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  formData: IProduct;
  products: IProduct[];
  token = localStorage.getItem('token')
  hearderOptions = new HttpHeaders().set("Authorization", "bearer " + this.token);
  constructor(private _httpClient: HttpClient) { }

  CreateProduct() {

    return this._httpClient.post(environment.url + 'api/Product/CreateProduct', this.formData, { headers: this.hearderOptions });
  }

  UpdateProduct() {
    return this._httpClient.put(environment.url + 'api/Product/UpdateProduct', this.formData, { headers: this.hearderOptions });
  }

  GetAllProducts() {
    return this._httpClient.get<IProduct[]>(environment.url + 'api/Product/GetAllProducts', { headers: this.hearderOptions }).subscribe(
      data => {
        this.products = data;
      }
    );
  }

  deleteProduct(id: string) {
    return this._httpClient.delete(environment.url + 'api/Product/DeleteProduct?productId=' + id, { headers: this.hearderOptions });
  }


}
