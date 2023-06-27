﻿using NUnit.Framework;
using NineMenMorris;
using GenericMorris;

namespace NineMenMorrisTest.AcceptanceTests
{
    public class MovingWhitePieceTests
    {
        private NineMenMorrisGame _nineMenMorrisGame;
        [SetUp]
        public void Setup()
        {
            _nineMenMorrisGame = new NineMenMorrisGame();
        }

        private void CompletePiecePlacement()
        {
            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A1);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A4);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_B2);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_C3);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_B4);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_C4);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_E5);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_E3);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_G1);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_G7);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_G4);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_F6);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_D7);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_D2);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_F2);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_D1);

            //White Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_A7);
            //Black Turn
            _nineMenMorrisGame.PlacePiece(NineMensPointList.POINT_E4);
        }
        [Test]
        public void testValidWhitePlayerMove()
        {
            CompletePiecePlacement();
            //White Player Move
            Assert.AreEqual(PlayerTurn.White, _nineMenMorrisGame.GetPlayerTurn());
            Assert.AreEqual(MoveStatus.Valid, _nineMenMorrisGame.MakeMove(NineMensPointList.POINT_G4, NineMensPointList.POINT_F4));
        }

        [Test]
        public void testInValidMoveOccupiedPoint()
        {
            CompletePiecePlacement();
            //White Player Move
            Assert.AreEqual(PlayerTurn.White, _nineMenMorrisGame.GetPlayerTurn());
            Assert.AreEqual(MoveStatus.Invalid, _nineMenMorrisGame.MakeMove(NineMensPointList.POINT_G4, NineMensPointList.POINT_G7));
        }

        [Test]
        public void testInValidMoveNonAdjecentPoint()
        {
            CompletePiecePlacement();
            //White Player Move
            Assert.AreEqual(PlayerTurn.White, _nineMenMorrisGame.GetPlayerTurn());
            Assert.AreEqual(MoveStatus.Invalid, _nineMenMorrisGame.MakeMove(NineMensPointList.POINT_G4, NineMensPointList.POINT_D3));
        }

        [Test]
        public void testInValidMoveBlackPieceSelection()
        {
            CompletePiecePlacement();
            //White Player Move
            Assert.AreEqual(PlayerTurn.White, _nineMenMorrisGame.GetPlayerTurn());
            Assert.AreEqual(MoveStatus.Invalid, _nineMenMorrisGame.MakeMove(NineMensPointList.POINT_F6, NineMensPointList.POINT_D6));
        }
    }
}
