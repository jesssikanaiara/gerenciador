import { HttpParams } from "@angular/common/http";

export class FiltroPaginacao{
    pagina: number;
    filtro: string;
    itensPorPagina: number;

    constructor(){
        this.filtro = '';
    }

    toHttpParams(): HttpParams{
        return new HttpParams().set('pagina', this.pagina.toString())
                               .set('filtro', this.filtro)
                               .set('itensPorPagina', this.itensPorPagina.toString());
    }
}