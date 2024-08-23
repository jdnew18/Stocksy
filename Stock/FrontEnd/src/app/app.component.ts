import { Component, OnInit, OnDestroy } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Stock } from './models/stock.model';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl: 'app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit, OnDestroy {
  title: string = 'Homes';
  webmasterName: string = 'Jason';
  pageStatusSubj$: BehaviorSubject<string> = new BehaviorSubject<string>('Good');
  data: Stock[] = [];

  constructor(private http: HttpClient){}

  ngOnInit() {
    this.pageStatusSubj$.subscribe((status) =>{
        setTimeout(() => {
          this.pageStatusSubj$.next(status === 'Good' ? 'Bad' : 'Good');
        }, 1000)
    });

    this.http.get<Stock[]>('http://localhost:5192/api/stock/get').subscribe(res => {
      this.data = res;
    });
    
  }
  
  ngOnDestroy() {
    this.pageStatusSubj$.unsubscribe();
  }
}
