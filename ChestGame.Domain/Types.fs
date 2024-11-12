module ChestGame.Domain

type File = A | B | C | D | E | F | G | H
type Rank = One | Two | Three | Four | Five | Six | Seven | Eight

type Position =  File * Rank

type Color = White | Black

type PieceType = King | Queen | Rook | Bishop | Knight | Pawn

type Piece = Color * PieceType

type Move = { From: Position
              To: Position
              Piece: Piece }

type GameStatus =
    | InProgress
    | Check of Color
    | Checkmate of Color
    | Stalemate
    | Draw

type GameState = {
    Board: Map<Position, Piece>
    CurrentTurn: Color
    Status: GameStatus
    MoveHistory: Move list
    CapturedPieces: Piece list
    }

type GetPotentialMove = (PieceType * Position) ->  Position list
type CreateGame = unit -> GameState

      
       