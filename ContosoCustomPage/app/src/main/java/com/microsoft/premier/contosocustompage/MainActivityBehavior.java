package com.microsoft.premier.contosocustompage;

import android.app.Activity;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivityBehavior {
    private Activity _activity;

    private Button button_increment;
    private TextView counter_label;

    public MainActivityBehavior(Activity mainActivity) {
        _activity = mainActivity;
    }

    public void SetupInterface(){
        counter_label = _activity.findViewById(R.id.counter_label);

        button_increment = _activity.findViewById(R.id.button_increment_counter);
        button_increment.setOnClickListener(mButtonListener);
    }

    private View.OnClickListener mButtonListener = new View.OnClickListener() {
        public void onClick(View v) {
            Integer n = Integer.parseInt((String)counter_label.getText());
            ++n;
            counter_label.setText(n.toString());
        }
    };
}
