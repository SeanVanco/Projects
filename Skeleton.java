package edu.vancous.Assign06;
import edu.vancous.Assign04.CharImage;
public class Skeleton extends Creature{

    public Skeleton(){}

    public Skeleton(int row, int col){
        super.setRow(row);
        super.setCol(col);
    }

    public String toString(){
        return("Skeleton at " + getRow() + "," + getCol());
    }

    public void draw(CharImage map){
        map.setPos(getRow(), getCol(), 'S');
    }
    
}
