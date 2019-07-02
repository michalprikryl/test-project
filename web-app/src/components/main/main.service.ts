import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { Contract, ElectricityContract, HeatContract } from 'src/models/contract';

@Injectable({
    providedIn: 'root'
})
export class MainService {

    constructor(private http: HttpClient) { }

    getElectricityContract() : Observable<ElectricityContract> {
        return this.getContract('electricity') as Observable<ElectricityContract>;
    }

    getHeatContract() : Observable<HeatContract> {
        return this.getContract('heat') as Observable<HeatContract>;
    }

    getContract(type : String) : Observable<Contract> {
        return this.http.get<Contract>(`${environment.api}contract/${type}/${Math.floor(Math.random() * 1001)}`);
    }

}