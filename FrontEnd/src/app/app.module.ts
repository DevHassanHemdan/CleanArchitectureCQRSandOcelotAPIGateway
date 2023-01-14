import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoriesComponent } from './categories/categories.component';
import { CreateProductComponent } from './products/create-product/create-product.component';

import { ProductsComponent } from './products/products.component';
import { CategoryService } from './Shared/category-service.service';
import { ProductService } from './Shared/product-service.service';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'createProduct', component: CreateProductComponent },
  { path: '', redirectTo: '/products', pathMatch: 'full' },
  { path: '**', component: ProductsComponent, pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    CreateProductComponent,
    CategoriesComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes)

  ],
  providers: [CategoryService, ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
