import { Product } from './product.model';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable()
export class Repository {

  public product: Product;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Product>(baseUrl + 'api/SampleData/GetProduct')
      .subscribe(result => {
        this.product = result;
      },
        error => console.error(error));
  }

}
