﻿using System.Collections.Generic;

namespace GameDevClone
{
	public class Game
	{
		public GameInfo.Genre MainGenre;
		public GameInfo.Genre SecondaryGenre;
		public List<GameInfo.GameModifier> Modifiers;

		// all go from 0 to 1000
		public int WritingLevel;
		public int DesignLevel;
		public int SoundLevel;
		public int GraphicsLevel;
		public int MajorBugs;
		public int MinorBugs;

	}
	public static class GameInfo
	{
		public enum Genre
		{
			RPG,
			FPS,
			Puzzle,
			Fighting,
			Simulator,
			Sports,
			Adventure,
            Table,
            Pirate,
            Robot
		}
		
		public enum GameModifier
		{
			Massive,
			Multiplayer,
			Online,
			Artistic,
			Hard,
			Sandbox
		}
	}
}
