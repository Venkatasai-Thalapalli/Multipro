import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'salary'
})
export class SalaryPipe implements PipeTransform {

  transform(basic: number): number {
    let salary= basic+ (basic*0.1) + (basic*0.05) + (basic*0.03)
    return salary;
  }

}
