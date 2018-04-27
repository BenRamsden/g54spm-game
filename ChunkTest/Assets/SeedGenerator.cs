﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class SeedGenerator { 	public int Seed { get; set; } 	public int ChunkSeed { get; set; } 	public int MineralSeed { get; set; }  	/// <summary> 	/// Initializes a new instance of the <see cref="SeedGenerator"/> class. 	/// </summary> 	public SeedGenerator() { 		this.Seed = 0; 		this.ChunkSeed = 0; 		this.MineralSeed = 0; 	}  	/// <summary> 	/// Initializes a new instance of the <see cref="SeedGenerator"/> class. 	/// </summary> 	/// <param name="seed">Seed.</param> 	/// <param name="mineralOffset">Mineral offset.</param> 	public SeedGenerator(int seed, int mineralOffset = -1) { 		if (mineralOffset < 0 || mineralOffset > seed.ToString().Length) 			mineralOffset = seed.ToString ().Length / 2;  		this.Seed = seed; 		this.ChunkSeed = int.Parse (seed.ToString ().Substring (0, mineralOffset - 1)); 		this.MineralSeed = int.Parse (seed.ToString ().Substring (mineralOffset)); 	}  	/// <summary> 	/// Initializes a new instance of the <see cref="SeedGenerator"/> class. 	/// </summary> 	/// <param name="seed">Seed.</param> 	/// <param name="mineralOffset">Mineral offset.</param> 	public SeedGenerator(string seed, int mineralOffset = -1) : this(seed.GetHashCode(), mineralOffset) { 		 	} } 