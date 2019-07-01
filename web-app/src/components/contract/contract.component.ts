import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';
import { Contract } from 'src/models/contract';

@Component({
    selector: 'contract',
    templateUrl: './contract.component.html',
    styleUrls: ['./contract.component.css']
})
export class ContractComponent implements OnInit {
    @Input() contract : Contract;
    constructor() { }

    ngOnInit() {
    }

}