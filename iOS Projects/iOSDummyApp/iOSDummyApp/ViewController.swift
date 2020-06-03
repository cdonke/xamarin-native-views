//
//  ViewController.swift
//  iOSDummyApp
//
//  Created by Christiano Donke on 01/06/20.
//  Copyright © 2020 Christiano Donke. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    
    
    @IBOutlet weak var lblCounter: UILabel!
    
    @IBAction func btnIncrement_OnClick() {
        var n = Int(lblCounter.text ?? "-2") ?? -2;
        n+=1;
        lblCounter.text=String(n);
    }
}

