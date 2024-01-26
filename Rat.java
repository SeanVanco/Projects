package edu.vancous.Assign06;
import edu.vancous.Assign04.CharImage;
public class Rat extends Creature{

    public Rat(){}

    public Rat(int row, int col){
        super.setRow(row);
        super.setCol(col);
    }

    public String toString(){
        return("Rat at " + getRow() + "," + getCol());
    }

    public void draw(CharImage map){
        map.setPos(getRow(), getCol(), 'R');
    }
    
}
