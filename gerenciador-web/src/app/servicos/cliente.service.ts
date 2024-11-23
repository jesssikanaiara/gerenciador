import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Cliente } from "../modelos/cliente.modelo";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
  })
export class ClienteService extends BaseService<Cliente>{
    constructor(public http: HttpClient) {
        super('clientes', http);
    }
}