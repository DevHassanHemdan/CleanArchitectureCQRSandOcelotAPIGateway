import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CategoryService } from '../../Shared/category-service.service';
import { ProductService } from '../../Shared/product-service.service';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
export class CreateProductComponent implements OnInit {

  constructor(public productService: ProductService, public categoryService: CategoryService) {

  }

  ngOnInit(): void {
    this.GetAllCategories();
    this.productService.GetAllProducts();
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form?.reset();
    this.productService.formData = {
      id: '00000000-0000-0000-0000-000000000000',
      productName: '',
      categoryId: '',
      description: '',
      pictureUrl: 'testst',
      price: 0,
      categoryName: ''
    }
  }

  GetAllCategories() {
    this.categoryService.GetCategories().subscribe(data => {
      this.categoryService.categories = data;
    })
  }

  onSubmit(form: NgForm) {
    debugger;
    if (this.productService.formData.id == '00000000-0000-0000-0000-000000000000') {
      this.insertRecord(form);
    } else {
      this.updateRecord(form);
    }
  }

  insertRecord(form: NgForm) {
    this.productService.CreateProduct().subscribe(
      res => {
        this.resetForm(form);
        this.productService.GetAllProducts();
      },
      err => {
        console.log(err);

      }
    );
  }

  updateRecord(form: NgForm) {
    this.productService.UpdateProduct().subscribe(
      res => {
        this.resetForm(form);
        this.productService.GetAllProducts();
      },
      err => {
        console.log(err);

      }
    );
  }



}
