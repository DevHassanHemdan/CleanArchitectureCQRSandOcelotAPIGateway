import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { CategoryService } from '../Shared/category-service.service';
import { ProductService } from '../Shared/product-service.service';
import { IProduct } from './../models/product.model';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  constructor(public productService: ProductService, public categoryService: CategoryService, private _router: Router) {

  }

  ngOnInit(): void {
    let token = localStorage.getItem('token')
    if (token == null)
      this._router.navigate(['login']);
    else
      this.GetAllProducts();
  }

  GetAllProducts() {
    this.productService.GetAllProducts();
  }
  GetAllCategories() {
    this.categoryService.GetCategories().subscribe(data => {
      this.categoryService.categories = data;
    })
  }

  PouplateForm(product: IProduct) {
    this.productService.formData = Object.assign({}, product);
  }

  onDeleteProduct(id: any) {
    if (confirm('Are you sure to delete this record?')) {
      this.productService.deleteProduct(id).subscribe(res => {
        this.productService.GetAllProducts();
      })
    }
  }


}
