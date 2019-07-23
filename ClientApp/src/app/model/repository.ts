import { Product } from './product.model';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

const productsUrl = '/api/products';
const ordersUrl = '/api/orders';

@Injectable()
export class Repository {

  product: Product;
  products: Product[];

  constructor(private http: HttpClient) {
    this.getProducts();
  }

  getProduct(id: number) {
    this.http.get(productsUrl + '/' + id).subscribe(response => { this.product = response; });
  }

  getProducts() {
    this.http.get<Product[]>(productsUrl)
      .subscribe(response => this.products = response);
  }


}
