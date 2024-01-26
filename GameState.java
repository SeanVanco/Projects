package edu.vancous.Assign06;
import edu.vancous.Assign04.CharImage;
import java.util.*;
import java.io.PrintWriter;

public class GameState implements Loadable{

    ArrayList<Loadable> List = new ArrayList<Loadable>();

    CharImage map = new CharImage(12, 30, '.');

    public Loadable createLoadable(String typeName) throws GameFileException{

        Loadable n;

        switch(typeName){
            case "Skeleton":{
                n = new Skeleton();
                break;
            }
            case "Rat":{
                n = new Rat();
                break;
            }
            case "Item" : {
                n = new Item();
                break;
            }
            case "Book" : {
                n = new Book();
                break;
            }
            default:{
                throw new GameFileException("Unknown type: " + typeName);
            }
        }
        return n;

    }

    public void load(Scanner input) throws GameFileException{
        
        map.clear();
        List.clear();

        int lines = input.nextInt();

        for(int i = 0; i<lines; i++){

            String typeName = input.next();

            Loadable m = createLoadable(typeName);

            m.load(input);

            List.add(m);

           if(m instanceof Drawable){

            ((Creature) m).draw(map);

           }
        }
    }

    public String toString(){

        StringBuilder s = new StringBuilder();

        s.append("MAP:\n" + map.getMapString() + "\n" + "CREATURES:\n");

        for(Loadable x: List){

            if(x instanceof Creature){

                s.append(x.toString() + "\n");

            }
        }

        s.append("INVENTORY:\n");

        for(Loadable y: List){

            if(y instanceof Item){

                s.append(y.toString() + "\n");

            }

        }


        String contents = s.toString();
        return contents;
        
    }

    public void save(String filename) throws GameFileException{

        try(PrintWriter write = new PrintWriter(filename)){

            write.print(this.toString());

            write.close();

        }
        catch(Exception e){

            throw new GameFileException("Failed to save file!", e);

        }
    }
    
}
