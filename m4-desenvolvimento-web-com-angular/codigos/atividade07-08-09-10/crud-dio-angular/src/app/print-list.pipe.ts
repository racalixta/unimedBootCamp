import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'printList',
  pure: false,    // sobre a puresa do pipe, nesse caso ele será um pipe impuro
})
export class PrintListPipe implements PipeTransform {

  transform(value: String[], ...args: unknown[]): unknown {
    let returnStr = '';
    if(value.length) {
      value.forEach(val => {
        returnStr = `${returnStr} ${val}, `;
      })
    }



    return returnStr;
  }

}
