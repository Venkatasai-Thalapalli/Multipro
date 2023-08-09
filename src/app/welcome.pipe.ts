import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'welcome'
})
export class WelcomePipe implements PipeTransform {

  transform(name:string, title:string='Mr.',comp:string="xyz",city:string="Delhi"): string {
   let msg="Welcome to our portal"+title+''+name+'company'+comp+'city'+city;
    return msg; 
   }

}
