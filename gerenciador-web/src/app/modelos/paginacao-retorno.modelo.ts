import { HttpParams } from "@angular/common/http";

export class PaginacaoRetorno<T>{
    lista: T[];
    totalItens: number;
}