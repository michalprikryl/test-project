export interface Contract {
    name: string;
    price: number;
}

export interface HeatContract extends Contract {
    temperatures: number[];
}

export interface ElectricityContract extends Contract {
    buildingType: BuildingType;
}

export enum BuildingType {
    Flat = "Flat",
    House = "House",
    Other = "Other"
}