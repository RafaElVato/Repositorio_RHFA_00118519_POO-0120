package com.RHFA_00118519.x;

public class Laptop {

    //Atributos
    private String tip, SisOP;

    //Setter y getter
    public Laptop(String tipo, String sistemaOp){
     tip = tipo;
     SisOP = sistemaOp;
    }

    //Metodos
    public void encendiendo(){
        System.out.println("Se esta iniciando el sistema " + SisOP + " Por favor, espere...");

        System.out.println("Bienvenido, el sistema se ha iniciado " + tip);
    }

    public void apagando(){
        System.out.println("Espere, se esta apagando el sistema...");
        System.out.println("Apagado exitoso, gracias por usar " + tip);
    }

}

