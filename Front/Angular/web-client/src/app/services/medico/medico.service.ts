import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Medico } from 'src/app/models/medico.model';

@Injectable({
  providedIn: 'root'
})
export class MedicoService {

  private readonly url: string;

  constructor(private httpClient: HttpClient) { 
    this.url = "https://localhost:44341/api/Medicos";
  }

  getAll():Observable<Medico[]>{
    return this.httpClient.get<Medico[]>(this.url);
  }
}
