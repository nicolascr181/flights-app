import { Component, DestroyRef, inject } from '@angular/core';
import { IJourney, IResponse, ISearchData } from '../list-flights-container/interfaces';
import { JourneyService } from 'src/app/services/journey.service';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [MessageService]
})
export class HomeComponent  {

  searchData! : ISearchData;
  journeys?: IJourney[]
  responses? : IResponse[]
  destroyRef = inject(DestroyRef);

  constructor(private journeyService: JourneyService,private messageService: MessageService){
    
  }

  search($event:ISearchData){
    this.searchData = $event;
    if(this.searchData){
      this.journeyService.getJourneyList(this.searchData)
      .pipe(takeUntilDestroyed(this.destroyRef))
      .subscribe({
        next:(res: IResponse[])=>{
          this.responses = res
          const hasEmptyJourneys = this.responses.some(response => response?.journeys?.length === 0);
          // Generate a console.log error if 'hasEmptyJourneys' is true
          if (hasEmptyJourneys) {
              this.messageService.add({ severity: 'warn', summary: 'Error', detail: "No available flights were found" });
          }
          else{
            this.messageService.add({ severity: 'success', summary: 'Success', detail: 'The flights were obtained successfully' });
          }
        },
        error:(err : any)=>{
          this.messageService.add({ severity: 'error', summary: 'Error', detail: err.statusText });
        }
        
      })
    }
    }


}
