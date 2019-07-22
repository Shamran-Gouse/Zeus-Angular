import { Product } from './model/product.model';
import { Repository } from './model/repository';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private repo: Repository) {}

  get product(): Product {
    return this.repo.product;
  }
}
