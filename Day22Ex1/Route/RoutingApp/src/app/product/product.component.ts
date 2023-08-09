import { Component } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  products:any[]=[
    {pid:1,price:1289,imgsrc:'assets/images/s2.jpg'},
    {pid:2,price:2290,imgsrc:'assets/images/s3.jpg'}
  ];
}
