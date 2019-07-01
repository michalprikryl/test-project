import { Component, OnInit } from '@angular/core';
import { MainService } from './main.service';

import { HeatContract, ElectricityContract } from '../../models/contract';

@Component({
    selector: 'main',
    templateUrl: './main.component.html',
    styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {
    heatContract: HeatContract;
    electricityContract: ElectricityContract;

    constructor(private cartService: MainService) { }

    ngOnInit() {
        this.cartService.getHeatContract().subscribe(h => this.heatContract = h);
        this.cartService.getElectricityContract().subscribe(e => this.electricityContract = e);
    }

}