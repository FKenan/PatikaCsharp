import java.util.ArrayList;

public class Threadad implements Runnable{
    private ArrayList<Integer> odd = new ArrayList<>();
    private ArrayList<Integer> even = new ArrayList<>();
    private ArrayList<Integer> main = new ArrayList<>();
    private final Object LOCK = new Object();

    public Threadad(ArrayList<Integer> main) {
        this.main = main;
    }

    @Override
    public void run() {
        synchronized (LOCK){
            for (int i =0 ;i<100 ; i++){
                if(main.get(i)%2 == 0)
                    even.add(main.get(i));
                else
                    odd.add(main.get(i));

            }
            System.out.println(this.odd);
            System.out.println(this.even);
        }
    }

}
