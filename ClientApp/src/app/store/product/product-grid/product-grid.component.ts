import { Product } from './../../../model/product.model';
import { Component, OnInit } from '@angular/core';
import { Repository } from 'src/app/model/repository';

@Component({
  selector: 'app-product-grid',
  templateUrl: './product-grid.component.html',
  styleUrls: ['./product-grid.component.css']
})
export class ProductGridComponent implements OnInit {

  constructor(private repo: Repository) { }

  ngOnInit() {
     console.log(this.products);
  }

  get products(): Product[] {
    return this.repo.products;
  }

}
