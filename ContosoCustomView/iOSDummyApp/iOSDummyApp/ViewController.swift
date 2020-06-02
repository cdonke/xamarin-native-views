//
//  ViewController.swift
//  iOSDummyApp
//
//  Created by Christiano Donke on 01/06/20.
//  Copyright © 2020 Christiano Donke. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    @IBOutlet weak var lblCounter: UILabel!

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    
    @IBAction func btnIncrement_OnClick(_ sender: Any) {
        var value = Int(lblCounter.text ?? "0") ?? -2;
        value+=1;
        
        lblCounter.text = String(value);
        
        lblCounter.sizeToFit();
    }
}

