import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatPrice'
})
export class FormatPrice implements PipeTransform{
  transform(value: number){
    return value.toLocaleString("en-us", {
      style: "currency",
      currency: "USD",
      minimumFractionDigits: 2,
    });;
  }
}
