import { Product } from './product.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
// import { Filter, Pagination } from './configClasses.repository';
// import { Order } from './order.model';

const productsUrl = '/api/products';
const ordersUrl = '/api/orders';

@Injectable()
export class Repository {

  product: Product;
  products: Product[];
  // orders: Order[] = [];

  // get pagination(): Pagination {
  // 	return this.paginationObject;
  // }

  // private filterObject = new Filter();
  // private paginationObject = new Pagination();

  constructor(private http: HttpClient) {
    this.getProducts();
  }

  getProduct(id: number) {
    this.http.get(productsUrl + '/' + id).subscribe(response => { this.product = response; });
  }

  // getProducts() {
  //   let url = productsUrl + '?related=' + this.filter.related;
  //   if (this.filter.category) {
  //     url += '&category=' + this.filter.category;
  //   }
  //   if (this.filter.search) {
  //     url += '&search=' + this.filter.search;
  //   }

  //   url += '&metadata=true';
  //   this.http.get<any>(url)
  //     .subscribe(response => {
  //       this.product = response.data;
  //       // this.pagination.currentPage = 1;
  //     });

  // }

  getProducts() {
    this.http.get<Product[]>(productsUrl)
      .subscribe(response => this.products = response);
  }

  createProduct(prod: Product) {
    const data = {
      imageUrl: prod.imageUrl,
      name: prod.name,
      description: prod.description,
      quantity: prod.quantity,
      reOrder: prod.reOrder,
      price: prod.price
    };

    this.http.post<number>(productsUrl, data)
      .subscribe(response => {
        prod.id = response;
        this.products.push(prod);
      });
  }

  replaceProduct(prod: Product) {
    const data = {
      imageUrl: prod.imageUrl,
      name: prod.name,
      description: prod.description,
      quantity: prod.quantity,
      reOrder: prod.reOrder,
      price: prod.price
    };

    this.http.put(productsUrl + '/' + prod.id, data)
      .subscribe(response => this.getProducts());
  }

  updateProduct(id: number, changes: Map<string, any>) {
    const patch = [];

    changes.forEach((value, key) =>
      patch.push({ op: 'replace', path: key, value: value }));

    this.http.patch(productsUrl + '/' + id, patch)
      .subscribe(response => this.getProducts());
  }

  deleteProduct(id: number) {
    this.http.delete(productsUrl + '/' + id)
      .subscribe(response => this.getProducts());
  }



  // storeSessionData(dataType: string, data: any) {
  //   return this.http.post('/api/session/' + dataType, data)
  //     .subscribe(response => { });
  // }

  // getSessionData(dataType: string): any {
  //   return this.http.get('/api/session/' + dataType);
  // }

  // getOrders() {
  //   this.http.get<Order[]>(ordersUrl)
  //     .subscribe(data => this.orders = data);
  // }

  // createOrder(order: Order) {
  //   this.http.post<any>(ordersUrl, {
  //     name: order.name,
  //     address: order.address,
  //     payment: order.payment,
  //     movies: order.movies
  //   }).subscribe(data => {
  //     order.orderConfirmation = data
  //     order.cart.clear();
  //     order.clear();
  //   });
  // }

  // shipOrder(order: Order) {
  //   this.http.post(ordersUrl + '/' + order.orderId, null)
  //     .subscribe(r => this.getOrders())
  // }
}
