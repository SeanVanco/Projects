package edu.vancous.Assign06;
import java.util.*;
public class Item implements Loadable{
    //wouldn't work with private
    protected String ID;
    protected int value;

    public Item(){
        ID = "";
        value = 0;
    }
    
    public Item(String ID, int value){
        this.ID = ID;
        this.value = value;
    }

    public String getID(){
        return this.ID;
    }

    public int getValue(){
        return this.value;
    }

    public void setID(String ID){
        this.ID = ID;
    }

    public void setValue(int value){
        this.value = value;
    }

    public String toString(){
        return(ID + " with value " + value);
    }

    public void load(Scanner input) throws GameFileException{
        //do this still
        try{
            ID = input.next();
            value = input.nextInt();
        }
        catch(Exception e){
            ID = "";
            value = 0;
            throw new GameFileException("Error loading Item", e);
        }

    }
    
}
