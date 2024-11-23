import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Cliente } from "../modelos/cliente.modelo";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
  })
export class VendaService extends BaseService<any>{
    constructor(public http: HttpClient) {
        super('venda', http);
    }
}