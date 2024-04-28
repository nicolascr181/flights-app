import { NgModule } from '@angular/core';

//PrimeNG Modules
import { ButtonModule } from 'primeng/button';
import { RippleModule } from 'primeng/ripple';
import { InputTextModule } from 'primeng/inputtext';
import { RadioButtonModule } from 'primeng/radiobutton';
import { DropdownModule } from 'primeng/dropdown';
import { DataViewModule } from 'primeng/dataview';
import { CardModule } from 'primeng/card';

@NgModule({
  declarations: [],
  imports: [],
  exports: [
    ButtonModule,
    RippleModule,
    InputTextModule,
    RadioButtonModule,
    DropdownModule,
    DataViewModule,
    CardModule
  ],
  bootstrap: [],
})
export class PrimeNGModule {}
